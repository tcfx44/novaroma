﻿using System.Collections.ObjectModel;

namespace Novaroma.Model.Search {

    public class MovieSearchModel: MediaSearchModel {

        public MovieSearchModel(ObservableCollection<string> mediaGenres): base(mediaGenres) {
        }

        protected override string SettingName {
            get { return "MovieSearchModel"; }
        }
    }
}
