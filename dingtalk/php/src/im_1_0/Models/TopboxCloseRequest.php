<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class TopboxCloseRequest extends Model
{
    /**
     * @var int
     */
    public $conversationType;

    /**
     * @var string
     */
    public $coolAppCode;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'conversationType'   => 'conversationType',
        'coolAppCode'        => 'coolAppCode',
        'openConversationId' => 'openConversationId',
        'outTrackId'         => 'outTrackId',
        'receiverUserIdList' => 'receiverUserIdList',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TopboxCloseRequest
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
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
