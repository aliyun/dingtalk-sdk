<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserSourceListRequest extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $openInstanceId;

    /**
     * @var int
     */
    public $orgId;

    /**
     * @var string
     */
    public $orgName;

    /**
     * @var int
     */
    public $productionType;
    protected $_name = [
        'corpId'         => 'corpId',
        'description'    => 'description',
        'openInstanceId' => 'openInstanceId',
        'orgId'          => 'orgId',
        'orgName'        => 'orgName',
        'productionType' => 'productionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->openInstanceId) {
            $res['openInstanceId'] = $this->openInstanceId;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->productionType) {
            $res['productionType'] = $this->productionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserSourceListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['openInstanceId'])) {
            $model->openInstanceId = $map['openInstanceId'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['productionType'])) {
            $model->productionType = $map['productionType'];
        }

        return $model;
    }
}
