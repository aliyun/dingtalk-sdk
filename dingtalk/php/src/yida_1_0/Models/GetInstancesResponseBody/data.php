<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponseBody\data\actionExecutor;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponseBody\data\originator;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var actionExecutor[]
     */
    public $actionExecutor;

    /**
     * @var string
     */
    public $approvedResult;

    /**
     * @var string
     */
    public $createTimeGMT;

    /**
     * @var mixed[]
     */
    public $data;

    /**
     * @var string
     */
    public $formUuid;

    /**
     * @var string
     */
    public $instanceStatus;

    /**
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @var originator
     */
    public $originator;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $version;
    protected $_name = [
        'actionExecutor'    => 'actionExecutor',
        'approvedResult'    => 'approvedResult',
        'createTimeGMT'     => 'createTimeGMT',
        'data'              => 'data',
        'formUuid'          => 'formUuid',
        'instanceStatus'    => 'instanceStatus',
        'modifiedTimeGMT'   => 'modifiedTimeGMT',
        'originator'        => 'originator',
        'processCode'       => 'processCode',
        'processInstanceId' => 'processInstanceId',
        'title'             => 'title',
        'version'           => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionExecutor) {
            $res['actionExecutor'] = [];
            if (null !== $this->actionExecutor && \is_array($this->actionExecutor)) {
                $n = 0;
                foreach ($this->actionExecutor as $item) {
                    $res['actionExecutor'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->approvedResult) {
            $res['approvedResult'] = $this->approvedResult;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->instanceStatus) {
            $res['instanceStatus'] = $this->instanceStatus;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionExecutor'])) {
            if (!empty($map['actionExecutor'])) {
                $model->actionExecutor = [];
                $n                     = 0;
                foreach ($map['actionExecutor'] as $item) {
                    $model->actionExecutor[$n++] = null !== $item ? actionExecutor::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['approvedResult'])) {
            $model->approvedResult = $map['approvedResult'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['instanceStatus'])) {
            $model->instanceStatus = $map['instanceStatus'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
