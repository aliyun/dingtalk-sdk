<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentriesResponseBody;

use AlibabaCloud\Tea\Model;

class resultItems extends Model
{
    /**
     * @description 是否是异步任务
     * 如果操作对象有子节点，则会异步处理
     * @var bool
     */
    public $async;

    /**
     * @description 源文件(夹)id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @description 错误原因, 异步任务该字段不返回
     *
     * @var string
     */
    public $errorCode;

    /**
     * @description 源文件(夹)空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 是否成功, 异步任务该字段不返回
     *
     * @var bool
     */
    public $success;

    /**
     * @description 操作对应根节点复制之后的文件id
     * 非失败的情况下同步或者异步都会返回
     * @var string
     */
    public $targetDentryId;

    /**
     * @description 操作对应根节点复制之后的空间id
     * 非失败的情况下同步或者异步都会返回
     * @var string
     */
    public $targetSpaceId;

    /**
     * @description 异步任务id，用于查询任务执行状态
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'async'          => 'async',
        'dentryId'       => 'dentryId',
        'errorCode'      => 'errorCode',
        'spaceId'        => 'spaceId',
        'success'        => 'success',
        'targetDentryId' => 'targetDentryId',
        'targetSpaceId'  => 'targetSpaceId',
        'taskId'         => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->async) {
            $res['async'] = $this->async;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->targetDentryId) {
            $res['targetDentryId'] = $this->targetDentryId;
        }
        if (null !== $this->targetSpaceId) {
            $res['targetSpaceId'] = $this->targetSpaceId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['async'])) {
            $model->async = $map['async'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['targetDentryId'])) {
            $model->targetDentryId = $map['targetDentryId'];
        }
        if (isset($map['targetSpaceId'])) {
            $model->targetSpaceId = $map['targetSpaceId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
