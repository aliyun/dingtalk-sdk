<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFormListInAppRequest extends Model
{
    /**
     * @description 应用编码。应用唯一标识。如：APP_XXX
     *
     * @var string
     */
    public $appType;

    /**
     * @description 支持两种表单类型。
     * 不传时默认单据和流程均返回。
     * @var string
     */
    public $formTypes;

    /**
     * @description 页码，不填默认为1。
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 单页返回的条目数，最大值100。
     * 不填默认为100。
     * @var int
     */
    public $pageSize;

    /**
     * @description 应用秘钥。在应用设置-部署运维-应用密钥中获取。
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 操作人userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'     => 'appType',
        'formTypes'   => 'formTypes',
        'pageNumber'  => 'pageNumber',
        'pageSize'    => 'pageSize',
        'systemToken' => 'systemToken',
        'userId'      => 'userId',
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
        if (null !== $this->formTypes) {
            $res['formTypes'] = $this->formTypes;
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFormListInAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formTypes'])) {
            $model->formTypes = $map['formTypes'];
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
