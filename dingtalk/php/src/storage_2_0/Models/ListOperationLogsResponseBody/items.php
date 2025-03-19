<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListOperationLogsResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example add_permission
     *
     * @var string
     */
    public $action;

    /**
     * @example 「我的文档/无标题文档」，给用户“你好”添加了「可编辑」权限
     *
     * @var string
     */
    public $details;

    /**
     * @example ovEQ1aYDoUrM8NldI7EPaDEuDfNce#AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3&USER:1557011407
     *
     * @var string
     */
    public $id;

    /**
     * @var int
     */
    public $operateTime;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example org_biz_meta_my_doc
     *
     * @var string
     */
    public $scene;

    /**
     * @example AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3
     *
     * @var string
     */
    public $subjectId;

    /**
     * @example 无标题文档
     *
     * @var string
     */
    public $subjectName;

    /**
     * @example DENTRY
     *
     * @var string
     */
    public $subjectType;

    /**
     * @example https://alidocs.dingtalk.com/i/nodes/AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3
     *
     * @var string
     */
    public $subjectUrl;
    protected $_name = [
        'action' => 'action',
        'details' => 'details',
        'id' => 'id',
        'operateTime' => 'operateTime',
        'operatorId' => 'operatorId',
        'scene' => 'scene',
        'subjectId' => 'subjectId',
        'subjectName' => 'subjectName',
        'subjectType' => 'subjectType',
        'subjectUrl' => 'subjectUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->details) {
            $res['details'] = $this->details;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->operateTime) {
            $res['operateTime'] = $this->operateTime;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->subjectId) {
            $res['subjectId'] = $this->subjectId;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->subjectType) {
            $res['subjectType'] = $this->subjectType;
        }
        if (null !== $this->subjectUrl) {
            $res['subjectUrl'] = $this->subjectUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['details'])) {
            $model->details = $map['details'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['operateTime'])) {
            $model->operateTime = $map['operateTime'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['subjectId'])) {
            $model->subjectId = $map['subjectId'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['subjectType'])) {
            $model->subjectType = $map['subjectType'];
        }
        if (isset($map['subjectUrl'])) {
            $model->subjectUrl = $map['subjectUrl'];
        }

        return $model;
    }
}
