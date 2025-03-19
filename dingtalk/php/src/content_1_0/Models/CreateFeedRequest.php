<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo;
use AlibabaCloud\Tea\Model;

class CreateFeedRequest extends Model
{
    /**
     * @var courseInfo
     */
    public $courseInfo;

    /**
     * @description This parameter is required.
     *
     * @example 16621*******284773
     *
     * @var string
     */
    public $createUserId;

    /**
     * @description This parameter is required.
     *
     * @var feedInfo
     */
    public $feedInfo;
    protected $_name = [
        'courseInfo' => 'courseInfo',
        'createUserId' => 'createUserId',
        'feedInfo' => 'feedInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseInfo) {
            $res['courseInfo'] = null !== $this->courseInfo ? $this->courseInfo->toMap() : null;
        }
        if (null !== $this->createUserId) {
            $res['createUserId'] = $this->createUserId;
        }
        if (null !== $this->feedInfo) {
            $res['feedInfo'] = null !== $this->feedInfo ? $this->feedInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseInfo'])) {
            $model->courseInfo = courseInfo::fromMap($map['courseInfo']);
        }
        if (isset($map['createUserId'])) {
            $model->createUserId = $map['createUserId'];
        }
        if (isset($map['feedInfo'])) {
            $model->feedInfo = feedInfo::fromMap($map['feedInfo']);
        }

        return $model;
    }
}
