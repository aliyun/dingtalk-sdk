<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeliverOneFeedRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $coverMediaId;

    /**
     * @var int
     */
    public $expireTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $summary;

    /**
     * @var string[]
     */
    public $userIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $videoMediaId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $videoTags;
    protected $_name = [
        'content' => 'content',
        'coverMediaId' => 'coverMediaId',
        'expireTime' => 'expireTime',
        'summary' => 'summary',
        'userIds' => 'userIds',
        'videoMediaId' => 'videoMediaId',
        'videoTags' => 'videoTags',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->coverMediaId) {
            $res['coverMediaId'] = $this->coverMediaId;
        }
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->videoMediaId) {
            $res['videoMediaId'] = $this->videoMediaId;
        }
        if (null !== $this->videoTags) {
            $res['videoTags'] = $this->videoTags;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeliverOneFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['coverMediaId'])) {
            $model->coverMediaId = $map['coverMediaId'];
        }
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['videoMediaId'])) {
            $model->videoMediaId = $map['videoMediaId'];
        }
        if (isset($map['videoTags'])) {
            $model->videoTags = $map['videoTags'];
        }

        return $model;
    }
}
