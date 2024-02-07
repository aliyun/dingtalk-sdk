<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\Tea\Model;

class InstallCoolAppRequest extends Model
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
     * @var mixed[]
     */
    public $feature;

    /**
     * @var string
     */
    public $installUid;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var mixed[]
     */
    public $options;

    /**
     * @var string
     */
    public $suiteId;
    protected $_name = [
        'appId'              => 'appId',
        'coolAppCode'        => 'coolAppCode',
        'corpId'             => 'corpId',
        'feature'            => 'feature',
        'installUid'         => 'installUid',
        'openConversationId' => 'openConversationId',
        'options'            => 'options',
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
        if (null !== $this->feature) {
            $res['feature'] = $this->feature;
        }
        if (null !== $this->installUid) {
            $res['installUid'] = $this->installUid;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallCoolAppRequest
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
            $model->feature = $map['feature'];
        }
        if (isset($map['installUid'])) {
            $model->installUid = $map['installUid'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['options'])) {
            $model->options = $map['options'];
        }
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }

        return $model;
    }
}
