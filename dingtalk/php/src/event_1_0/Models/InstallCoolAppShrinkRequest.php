<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\Tea\Model;

class InstallCoolAppShrinkRequest extends Model
{
    /**
     * @var int
     */
    public $appId;

    /**
     * @var string
     */
    public $coolAppCode;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $featureShrink;

    /**
     * @var string
     */
    public $installUid;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $optionsShrink;

    /**
     * @var string
     */
    public $suiteId;
    protected $_name = [
        'appId'              => 'appId',
        'coolAppCode'        => 'coolAppCode',
        'corpId'             => 'corpId',
        'featureShrink'      => 'feature',
        'installUid'         => 'installUid',
        'openConversationId' => 'openConversationId',
        'optionsShrink'      => 'options',
        'suiteId'            => 'suiteId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->featureShrink) {
            $res['feature'] = $this->featureShrink;
        }
        if (null !== $this->installUid) {
            $res['installUid'] = $this->installUid;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->optionsShrink) {
            $res['options'] = $this->optionsShrink;
        }
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallCoolAppShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['feature'])) {
            $model->featureShrink = $map['feature'];
        }
        if (isset($map['installUid'])) {
            $model->installUid = $map['installUid'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['options'])) {
            $model->optionsShrink = $map['options'];
        }
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }

        return $model;
    }
}
