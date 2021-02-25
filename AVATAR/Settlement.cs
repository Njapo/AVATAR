using System;
using System.Collections.Generic;
using System.Text;

namespace AVATAR
{
    class Settlement
    {
        public AVATAR AVATAR { get; set; }
        public List<Earthbender> earthbenders;
        public List<Firebender> firebenders;
        public List<Waterbender> waterbenders;
        public List<Airbender> airbenders;
        public Settlement(List<Earthbender> earthbenders, List<Airbender> airbenders, List<Waterbender> waterbenders, List<Firebender> firebenders, AVATAR AVATAR)
        {
            this.earthbenders = earthbenders;
            this.firebenders = firebenders;
            this.airbenders = airbenders;
            this.waterbenders = waterbenders;
            this.AVATAR = AVATAR;

        }
    }
}
