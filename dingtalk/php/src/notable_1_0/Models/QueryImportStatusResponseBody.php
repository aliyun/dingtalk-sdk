<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryImportStatusResponseBody extends Model
{
    /**
     * @var int
     */
    public $count;

    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMessage;

    /**
     * @var string
     */
    public $importId;

    /**
     * @var string
     */
    public $phase;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string[]
     */
    public $tableIds;
    protected $_name = [
        'count' => 'count',
        'errorCode' => 'errorCode',
        'errorMessage' => 'errorMessage',
        'importId' => 'importId',
        'phase' => 'phase',
        'status' => 'status',
        'tableIds' => 'tableIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMessage) {
            $res['errorMessage'] = $this->errorMessage;
        }
        if (null !== $this->importId) {
            $res['importId'] = $this->importId;
        }
        if (null !== $this->phase) {
            $res['phase'] = $this->phase;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->tableIds) {
            $res['tableIds'] = $this->tableIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryImportStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMessage'])) {
            $model->errorMessage = $map['errorMessage'];
        }
        if (isset($map['importId'])) {
            $model->importId = $map['importId'];
        }
        if (isset($map['phase'])) {
            $model->phase = $map['phase'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['tableIds'])) {
            if (!empty($map['tableIds'])) {
                $model->tableIds = $map['tableIds'];
            }
        }

        return $model;
    }
}
