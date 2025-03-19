<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponseBody\result\liveInfoPopModelList;

use AlibabaCloud\Tea\Model;

class extraInfo extends Model
{
    /**
     * @var bool
     */
    public $hasSubscribed;

    /**
     * @var bool
     */
    public $isForecastExpired;

    /**
     * @var int
     */
    public $watchProgressMs;
    protected $_name = [
        'hasSubscribed' => 'hasSubscribed',
        'isForecastExpired' => 'isForecastExpired',
        'watchProgressMs' => 'watchProgressMs',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasSubscribed) {
            $res['hasSubscribed'] = $this->hasSubscribed;
        }
        if (null !== $this->isForecastExpired) {
            $res['isForecastExpired'] = $this->isForecastExpired;
        }
        if (null !== $this->watchProgressMs) {
            $res['watchProgressMs'] = $this->watchProgressMs;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extraInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasSubscribed'])) {
            $model->hasSubscribed = $map['hasSubscribed'];
        }
        if (isset($map['isForecastExpired'])) {
            $model->isForecastExpired = $map['isForecastExpired'];
        }
        if (isset($map['watchProgressMs'])) {
            $model->watchProgressMs = $map['watchProgressMs'];
        }

        return $model;
    }
}
