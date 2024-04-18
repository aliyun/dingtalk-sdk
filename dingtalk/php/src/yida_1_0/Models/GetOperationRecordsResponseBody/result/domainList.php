<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsResponseBody\result\domainList\operatorAgentIdList;
use AlibabaCloud\Tea\Model;

class domainList extends Model
{
    /**
     * @example return
     *
     * @var string
     */
    public $action;

    /**
     * @example 2021-02-01
     *
     * @var string
     */
    public $activeTimeGMT;

    /**
     * @example act-xxaanfaf
     *
     * @var string
     */
    public $activityId;

    /**
     * @example https://oss.com/Signature.pdf
     *
     * @var string
     */
    public $digitalSignature;

    /**
     * @example https://oss.com/a.pdf
     *
     * @var string
     */
    public $files;

    /**
     * @example 同意
     *
     * @var string
     */
    public $formatAction;

    /**
     * @example 2021-01-01
     *
     * @var string
     */
    public $operateTimeGMT;

    /**
     * @example remove
     *
     * @var string
     */
    public $operateType;

    /**
     * @example manager123
     *
     * @var string
     */
    public $operator;

    /**
     * @example 1732223326,1232321888,12188991
     *
     * @var operatorAgentIdList[]
     */
    public $operatorAgentIdList;

    /**
     * @example 张三
     *
     * @var string
     */
    public $operatorDisplayName;

    /**
     * @example 李四
     *
     * @var string
     */
    public $operatorName;

    /**
     * @example 无冬
     *
     * @var string
     */
    public $operatorNickName;

    /**
     * @example https://oss.com/a.jpeg
     *
     * @var string
     */
    public $operatorPhotoUrl;

    /**
     * @example 良好
     *
     * @var string
     */
    public $operatorStatus;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $remark;

    /**
     * @example 请购类型
     *
     * @var string
     */
    public $showName;

    /**
     * @example 12
     *
     * @var int
     */
    public $size;

    /**
     * @example 同步
     *
     * @var string
     */
    public $taskExecuteType;

    /**
     * @example 2021-01-01
     *
     * @var int
     */
    public $taskHoldTimeGMT;

    /**
     * @example task-123
     *
     * @var string
     */
    public $taskId;

    /**
     * @example append task
     *
     * @var string
     */
    public $taskType;

    /**
     * @example i18n
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'action'              => 'action',
        'activeTimeGMT'       => 'activeTimeGMT',
        'activityId'          => 'activityId',
        'digitalSignature'    => 'digitalSignature',
        'files'               => 'files',
        'formatAction'        => 'formatAction',
        'operateTimeGMT'      => 'operateTimeGMT',
        'operateType'         => 'operateType',
        'operator'            => 'operator',
        'operatorAgentIdList' => 'operatorAgentIdList',
        'operatorDisplayName' => 'operatorDisplayName',
        'operatorName'        => 'operatorName',
        'operatorNickName'    => 'operatorNickName',
        'operatorPhotoUrl'    => 'operatorPhotoUrl',
        'operatorStatus'      => 'operatorStatus',
        'processInstanceId'   => 'processInstanceId',
        'remark'              => 'remark',
        'showName'            => 'showName',
        'size'                => 'size',
        'taskExecuteType'     => 'taskExecuteType',
        'taskHoldTimeGMT'     => 'taskHoldTimeGMT',
        'taskId'              => 'taskId',
        'taskType'            => 'taskType',
        'type'                => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->activeTimeGMT) {
            $res['activeTimeGMT'] = $this->activeTimeGMT;
        }
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->digitalSignature) {
            $res['digitalSignature'] = $this->digitalSignature;
        }
        if (null !== $this->files) {
            $res['files'] = $this->files;
        }
        if (null !== $this->formatAction) {
            $res['formatAction'] = $this->formatAction;
        }
        if (null !== $this->operateTimeGMT) {
            $res['operateTimeGMT'] = $this->operateTimeGMT;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->operatorAgentIdList) {
            $res['operatorAgentIdList'] = [];
            if (null !== $this->operatorAgentIdList && \is_array($this->operatorAgentIdList)) {
                $n = 0;
                foreach ($this->operatorAgentIdList as $item) {
                    $res['operatorAgentIdList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operatorDisplayName) {
            $res['operatorDisplayName'] = $this->operatorDisplayName;
        }
        if (null !== $this->operatorName) {
            $res['operatorName'] = $this->operatorName;
        }
        if (null !== $this->operatorNickName) {
            $res['operatorNickName'] = $this->operatorNickName;
        }
        if (null !== $this->operatorPhotoUrl) {
            $res['operatorPhotoUrl'] = $this->operatorPhotoUrl;
        }
        if (null !== $this->operatorStatus) {
            $res['operatorStatus'] = $this->operatorStatus;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->showName) {
            $res['showName'] = $this->showName;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->taskExecuteType) {
            $res['taskExecuteType'] = $this->taskExecuteType;
        }
        if (null !== $this->taskHoldTimeGMT) {
            $res['taskHoldTimeGMT'] = $this->taskHoldTimeGMT;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return domainList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['activeTimeGMT'])) {
            $model->activeTimeGMT = $map['activeTimeGMT'];
        }
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['digitalSignature'])) {
            $model->digitalSignature = $map['digitalSignature'];
        }
        if (isset($map['files'])) {
            $model->files = $map['files'];
        }
        if (isset($map['formatAction'])) {
            $model->formatAction = $map['formatAction'];
        }
        if (isset($map['operateTimeGMT'])) {
            $model->operateTimeGMT = $map['operateTimeGMT'];
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['operatorAgentIdList'])) {
            if (!empty($map['operatorAgentIdList'])) {
                $model->operatorAgentIdList = [];
                $n                          = 0;
                foreach ($map['operatorAgentIdList'] as $item) {
                    $model->operatorAgentIdList[$n++] = null !== $item ? operatorAgentIdList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorDisplayName'])) {
            $model->operatorDisplayName = $map['operatorDisplayName'];
        }
        if (isset($map['operatorName'])) {
            $model->operatorName = $map['operatorName'];
        }
        if (isset($map['operatorNickName'])) {
            $model->operatorNickName = $map['operatorNickName'];
        }
        if (isset($map['operatorPhotoUrl'])) {
            $model->operatorPhotoUrl = $map['operatorPhotoUrl'];
        }
        if (isset($map['operatorStatus'])) {
            $model->operatorStatus = $map['operatorStatus'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['showName'])) {
            $model->showName = $map['showName'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['taskExecuteType'])) {
            $model->taskExecuteType = $map['taskExecuteType'];
        }
        if (isset($map['taskHoldTimeGMT'])) {
            $model->taskHoldTimeGMT = $map['taskHoldTimeGMT'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
