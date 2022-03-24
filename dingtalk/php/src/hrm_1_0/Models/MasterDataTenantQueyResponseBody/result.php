<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataTenantQueyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 该租户是否已向主数据同步数据
     *
     * @var bool
     */
    public $hasData;

    /**
     * @description 该租户是否有向主数据写数据的权限
     *
     * @var bool
     */
    public $integrateDataAuth;

    /**
     * @description 租户名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 调用方是否有读该租户数据的权限
     *
     * @var bool
     */
    public $readAuth;

    /**
     * @description 租户 id
     *
     * @var int
     */
    public $tenantId;

    /**
     * @description 租户类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'hasData'           => 'hasData',
        'integrateDataAuth' => 'integrateDataAuth',
        'name'              => 'name',
        'readAuth'          => 'readAuth',
        'tenantId'          => 'tenantId',
        'type'              => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasData) {
            $res['hasData'] = $this->hasData;
        }
        if (null !== $this->integrateDataAuth) {
            $res['integrateDataAuth'] = $this->integrateDataAuth;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->readAuth) {
            $res['readAuth'] = $this->readAuth;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasData'])) {
            $model->hasData = $map['hasData'];
        }
        if (isset($map['integrateDataAuth'])) {
            $model->integrateDataAuth = $map['integrateDataAuth'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['readAuth'])) {
            $model->readAuth = $map['readAuth'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
