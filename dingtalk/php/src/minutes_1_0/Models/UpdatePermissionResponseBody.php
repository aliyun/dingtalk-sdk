<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponseBody\failMemberInfoList;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponseBody\memberPermissionOperationResults;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponseBody\shareScopeResult;
use AlibabaCloud\Tea\Model;

class UpdatePermissionResponseBody extends Model
{
    /**
     * @var bool
     */
    public $allSucceeded;

    /**
     * @var failMemberInfoList[]
     */
    public $failMemberInfoList;

    /**
     * @var memberPermissionOperationResults[]
     */
    public $memberPermissionOperationResults;

    /**
     * @example v2
     *
     * @var string
     */
    public $modelVersion;

    /**
     * @var bool
     */
    public $partialSuccess;

    /**
     * @var shareScopeResult
     */
    public $shareScopeResult;
    protected $_name = [
        'allSucceeded' => 'allSucceeded',
        'failMemberInfoList' => 'failMemberInfoList',
        'memberPermissionOperationResults' => 'memberPermissionOperationResults',
        'modelVersion' => 'modelVersion',
        'partialSuccess' => 'partialSuccess',
        'shareScopeResult' => 'shareScopeResult',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allSucceeded) {
            $res['allSucceeded'] = $this->allSucceeded;
        }
        if (null !== $this->failMemberInfoList) {
            $res['failMemberInfoList'] = [];
            if (null !== $this->failMemberInfoList && \is_array($this->failMemberInfoList)) {
                $n = 0;
                foreach ($this->failMemberInfoList as $item) {
                    $res['failMemberInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->memberPermissionOperationResults) {
            $res['memberPermissionOperationResults'] = [];
            if (null !== $this->memberPermissionOperationResults && \is_array($this->memberPermissionOperationResults)) {
                $n = 0;
                foreach ($this->memberPermissionOperationResults as $item) {
                    $res['memberPermissionOperationResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->modelVersion) {
            $res['modelVersion'] = $this->modelVersion;
        }
        if (null !== $this->partialSuccess) {
            $res['partialSuccess'] = $this->partialSuccess;
        }
        if (null !== $this->shareScopeResult) {
            $res['shareScopeResult'] = null !== $this->shareScopeResult ? $this->shareScopeResult->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allSucceeded'])) {
            $model->allSucceeded = $map['allSucceeded'];
        }
        if (isset($map['failMemberInfoList'])) {
            if (!empty($map['failMemberInfoList'])) {
                $model->failMemberInfoList = [];
                $n = 0;
                foreach ($map['failMemberInfoList'] as $item) {
                    $model->failMemberInfoList[$n++] = null !== $item ? failMemberInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['memberPermissionOperationResults'])) {
            if (!empty($map['memberPermissionOperationResults'])) {
                $model->memberPermissionOperationResults = [];
                $n = 0;
                foreach ($map['memberPermissionOperationResults'] as $item) {
                    $model->memberPermissionOperationResults[$n++] = null !== $item ? memberPermissionOperationResults::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['modelVersion'])) {
            $model->modelVersion = $map['modelVersion'];
        }
        if (isset($map['partialSuccess'])) {
            $model->partialSuccess = $map['partialSuccess'];
        }
        if (isset($map['shareScopeResult'])) {
            $model->shareScopeResult = shareScopeResult::fromMap($map['shareScopeResult']);
        }

        return $model;
    }
}
