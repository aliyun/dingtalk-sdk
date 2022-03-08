<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListTableDataByFormInstanceIdTableIdRequest extends Model
{
    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 表单ID
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 当前页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页记录数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 需要查找的子表单组件的唯一标识
     *
     * @var string
     */
    public $tableFieldId;

    /**
     * @description 钉钉的userId
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
