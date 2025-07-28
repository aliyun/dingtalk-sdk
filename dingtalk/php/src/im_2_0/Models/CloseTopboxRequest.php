<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models;

use AlibabaCloud\Tea\Model;

class CloseTopboxRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $conversationType;

    /**
     * @example COOLAPP-x-xxx
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @example 6dx-xxx-xxx
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @example cidxxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example 123xxx
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @example dingxxx
     *
     * @var string
     */
    public $robotCode;

    /**
     * @example jHsR7xxx
     *
     * @var string
     */
    public $unoinId;

    /**
     * @example 011xxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'conversationType' => 'conversationType',
        'coolAppCode' => 'coolAppCode',
        'groupTemplateId' => 'groupTemplateId',
        'openConversationId' => 'openConversationId',
        'outTrackId' => 'outTrackId',
        'robotCode' => 'robotCode',
        'unoinId' => 'unoinId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->unoinId) {
            $res['unoinId'] = $this->unoinId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseTopboxRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['unoinId'])) {
            $model->unoinId = $map['unoinId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
