<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListResponseBody\result\liveInfoPopModelList;

use AlibabaCloud\Tea\Model;

class hasSubscribed extends Model
{
    /**
     * @description 是否关注
     *
     * @var bool
     */
    public $hasSubscribed;

    /**
     * @description 预告是否过期
     *
     * @var bool
     */
    public $isForecastExpired;

    /**
     * @description 回放观看进度
     *
     * @var int
     */
    public $watchProgressMs;
    protected $_name = [
        'hasSubscribed'     => 'hasSubscribed',
        'isForecastExpired' => 'isForecastExpired',
        'watchProgressMs'   => 'watchProgressMs',
    ];

    public function validate()
    {
    }

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
     * @return hasSubscribed
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
