<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpgradeTemplateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingcd2016f425331dc1acaaa37764f94726
     *
     * @var string
     */
    public $channelCorpId;

    /**
     * @var bool
     */
    public $forceUpgrade;

    /**
     * @description This parameter is required.
     *
     * @example dingcd2016f425331dc1acaaa37764f94726
     *
     * @var string
     */
    public $tmcCorpId;
    protected $_name = [
        'channelCorpId' => 'channelCorpId',
        'forceUpgrade'  => 'forceUpgrade',
        'tmcCorpId'     => 'tmcCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCorpId) {
            $res['channelCorpId'] = $this->channelCorpId;
        }
        if (null !== $this->forceUpgrade) {
            $res['forceUpgrade'] = $this->forceUpgrade;
        }
        if (null !== $this->tmcCorpId) {
            $res['tmcCorpId'] = $this->tmcCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpgradeTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCorpId'])) {
            $model->channelCorpId = $map['channelCorpId'];
        }
        if (isset($map['forceUpgrade'])) {
            $model->forceUpgrade = $map['forceUpgrade'];
        }
        if (isset($map['tmcCorpId'])) {
            $model->tmcCorpId = $map['tmcCorpId'];
        }

        return $model;
    }
}
