<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastRequest\formComponentValues;
use AlibabaCloud\Tea\Model;

class ProcessForecastRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @description 审批流的唯一码
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 部门ID
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 审批发起人的userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 表单数据内容，控件列表
     *
     * @var formComponentValues[]
     */
    public $formComponentValues;
    protected $_name = [
        'dingCorpId'          => 'dingCorpId',
        'dingOrgId'           => 'dingOrgId',
        'dingIsvOrgId'        => 'dingIsvOrgId',
        'dingSuiteKey'        => 'dingSuiteKey',
        'dingTokenGrantType'  => 'dingTokenGrantType',
        'requestId'           => 'RequestId',
        'processCode'         => 'processCode',
        'deptId'              => 'deptId',
        'userId'              => 'userId',
        'formComponentValues' => 'formComponentValues',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->requestId) {
            $res['RequestId'] = $this->requestId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->formComponentValues) {
            $res['formComponentValues'] = [];
            if (null !== $this->formComponentValues && \is_array($this->formComponentValues)) {
                $n = 0;
                foreach ($this->formComponentValues as $item) {
                    $res['formComponentValues'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProcessForecastRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['RequestId'])) {
            $model->requestId = $map['RequestId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['formComponentValues'])) {
            if (!empty($map['formComponentValues'])) {
                $model->formComponentValues = [];
                $n                          = 0;
                foreach ($map['formComponentValues'] as $item) {
                    $model->formComponentValues[$n++] = null !== $item ? formComponentValues::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
