<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListTableDataByFormInstanceIdTableIdRequest extends Model
{
    /**
     * @var string
     */
    public $appType;

    /**
     * @example FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example 10
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 50
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example hexxxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example tableField_ksyaujq1
     *
     * @var string
     */
    public $tableFieldId;

    /**
     * @example 未知
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'      => 'appType',
        'formUuid'     => 'formUuid',
        'pageNumber'   => 'pageNumber',
        'pageSize'     => 'pageSize',
        'systemToken'  => 'systemToken',
        'tableFieldId' => 'tableFieldId',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->tableFieldId) {
            $res['tableFieldId'] = $this->tableFieldId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListTableDataByFormInstanceIdTableIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['tableFieldId'])) {
            $model->tableFieldId = $map['tableFieldId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
