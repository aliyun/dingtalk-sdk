<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileTaskInfosByPageResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $classTagId;

    /**
     * @example 大于 0 小于 1 等于 2
     *
     * @var string
     */
    public $classTagOperator;

    /**
     * @example 普通文件
     *
     * @var string
     */
    public $classTagText;

    /**
     * @example 1
     *
     * @var int
     */
    public $creatorLeaveStatus;

    /**
     * @var string[]
     */
    public $dealFileFormats;

    /**
     * @example 大于等于 0 小于等于 1
     *
     * @var int
     */
    public $dealFileOperator;

    /**
     * @var string[]
     */
    public $dealFileScopes;

    /**
     * @example 1234
     *
     * @var int
     */
    public $dealFileSize;

    /**
     * @example 12345
     *
     * @var int
     */
    public $fileCreateTimeEnd;

    /**
     * @example 12345
     *
     * @var int
     */
    public $fileCreateTimeStart;

    /**
     * @example 12345
     *
     * @var int
     */
    public $fileModifiedTimeEnd;

    /**
     * @example 12345
     *
     * @var int
     */
    public $fileModifiedTimeStart;

    /**
     * @example 12345
     *
     * @var int
     */
    public $taskCreateTime;

    /**
     * @example 钉三多
     *
     * @var string
     */
    public $taskCreatorName;

    /**
     * @example 钉三多
     *
     * @var string
     */
    public $taskDeleterName;

    /**
     * @example 123
     *
     * @var int
     */
    public $taskId;

    /**
     * @example 初始化完毕 0 正在删除 1 删除完成 2 正在回滚 3 回滚完成 4 数据初始化中 5  任务状态异常 6  待删除 7
     *
     * @var int
     */
    public $taskStatus;
    protected $_name = [
        'classTagId' => 'classTagId',
        'classTagOperator' => 'classTagOperator',
        'classTagText' => 'classTagText',
        'creatorLeaveStatus' => 'creatorLeaveStatus',
        'dealFileFormats' => 'dealFileFormats',
        'dealFileOperator' => 'dealFileOperator',
        'dealFileScopes' => 'dealFileScopes',
        'dealFileSize' => 'dealFileSize',
        'fileCreateTimeEnd' => 'fileCreateTimeEnd',
        'fileCreateTimeStart' => 'fileCreateTimeStart',
        'fileModifiedTimeEnd' => 'fileModifiedTimeEnd',
        'fileModifiedTimeStart' => 'fileModifiedTimeStart',
        'taskCreateTime' => 'taskCreateTime',
        'taskCreatorName' => 'taskCreatorName',
        'taskDeleterName' => 'taskDeleterName',
        'taskId' => 'taskId',
        'taskStatus' => 'taskStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classTagId) {
            $res['classTagId'] = $this->classTagId;
        }
        if (null !== $this->classTagOperator) {
            $res['classTagOperator'] = $this->classTagOperator;
        }
        if (null !== $this->classTagText) {
            $res['classTagText'] = $this->classTagText;
        }
        if (null !== $this->creatorLeaveStatus) {
            $res['creatorLeaveStatus'] = $this->creatorLeaveStatus;
        }
        if (null !== $this->dealFileFormats) {
            $res['dealFileFormats'] = $this->dealFileFormats;
        }
        if (null !== $this->dealFileOperator) {
            $res['dealFileOperator'] = $this->dealFileOperator;
        }
        if (null !== $this->dealFileScopes) {
            $res['dealFileScopes'] = $this->dealFileScopes;
        }
        if (null !== $this->dealFileSize) {
            $res['dealFileSize'] = $this->dealFileSize;
        }
        if (null !== $this->fileCreateTimeEnd) {
            $res['fileCreateTimeEnd'] = $this->fileCreateTimeEnd;
        }
        if (null !== $this->fileCreateTimeStart) {
            $res['fileCreateTimeStart'] = $this->fileCreateTimeStart;
        }
        if (null !== $this->fileModifiedTimeEnd) {
            $res['fileModifiedTimeEnd'] = $this->fileModifiedTimeEnd;
        }
        if (null !== $this->fileModifiedTimeStart) {
            $res['fileModifiedTimeStart'] = $this->fileModifiedTimeStart;
        }
        if (null !== $this->taskCreateTime) {
            $res['taskCreateTime'] = $this->taskCreateTime;
        }
        if (null !== $this->taskCreatorName) {
            $res['taskCreatorName'] = $this->taskCreatorName;
        }
        if (null !== $this->taskDeleterName) {
            $res['taskDeleterName'] = $this->taskDeleterName;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
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
        if (isset($map['classTagId'])) {
            $model->classTagId = $map['classTagId'];
        }
        if (isset($map['classTagOperator'])) {
            $model->classTagOperator = $map['classTagOperator'];
        }
        if (isset($map['classTagText'])) {
            $model->classTagText = $map['classTagText'];
        }
        if (isset($map['creatorLeaveStatus'])) {
            $model->creatorLeaveStatus = $map['creatorLeaveStatus'];
        }
        if (isset($map['dealFileFormats'])) {
            if (!empty($map['dealFileFormats'])) {
                $model->dealFileFormats = $map['dealFileFormats'];
            }
        }
        if (isset($map['dealFileOperator'])) {
            $model->dealFileOperator = $map['dealFileOperator'];
        }
        if (isset($map['dealFileScopes'])) {
            if (!empty($map['dealFileScopes'])) {
                $model->dealFileScopes = $map['dealFileScopes'];
            }
        }
        if (isset($map['dealFileSize'])) {
            $model->dealFileSize = $map['dealFileSize'];
        }
        if (isset($map['fileCreateTimeEnd'])) {
            $model->fileCreateTimeEnd = $map['fileCreateTimeEnd'];
        }
        if (isset($map['fileCreateTimeStart'])) {
            $model->fileCreateTimeStart = $map['fileCreateTimeStart'];
        }
        if (isset($map['fileModifiedTimeEnd'])) {
            $model->fileModifiedTimeEnd = $map['fileModifiedTimeEnd'];
        }
        if (isset($map['fileModifiedTimeStart'])) {
            $model->fileModifiedTimeStart = $map['fileModifiedTimeStart'];
        }
        if (isset($map['taskCreateTime'])) {
            $model->taskCreateTime = $map['taskCreateTime'];
        }
        if (isset($map['taskCreatorName'])) {
            $model->taskCreatorName = $map['taskCreatorName'];
        }
        if (isset($map['taskDeleterName'])) {
            $model->taskDeleterName = $map['taskDeleterName'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }

        return $model;
    }
}
