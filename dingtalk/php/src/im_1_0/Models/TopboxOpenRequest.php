<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class TopboxOpenRequest extends Model
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
     * @example 1850042969000
     *
     * @var int
     */
    public $expiredTime;

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
     * @example ios|win
     *
     * @var string
     */
    public $platforms;

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
        'expiredTime'        => 'expiredTime',
        'openConversationId' => 'openConversationId',
        'outTrackId'         => 'outTrackId',
        'platforms'          => 'platforms',
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
        if (null !== $this->expiredTime) {
            $res['expiredTime'] = $this->expiredTime;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->platforms) {
            $res['platforms'] = $this->platforms;
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
     * @return TopboxOpenRequest
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
        if (isset($map['expiredTime'])) {
            $model->expiredTime = $map['expiredTime'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['platforms'])) {
            $model->platforms = $map['platforms'];
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
