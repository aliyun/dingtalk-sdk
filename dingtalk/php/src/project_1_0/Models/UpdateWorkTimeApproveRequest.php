<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateWorkTimeApproveRequest extends Model
{
    /**
     * @example 2023-04-04T00:00:00.000Z
     *
     * @var string
     */
    public $finishTime;

    /**
     * @example 1233
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example NEW
     *
     * @var string
     */
    public $status;

    /**
     * @example 2023-04-04T00:00:00.000Z
     *
     * @var string
     */
    public $submitTime;

    /**
     * @example xxxx 用工申请
     *
     * @var string
     */
    public $title;

    /**
     * @example https://xxxbpms.xxx/xxxx
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'finishTime' => 'finishTime',
        'instanceId' => 'instanceId',
        'status' => 'status',
        'submitTime' => 'submitTime',
        'title' => 'title',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateWorkTimeApproveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
