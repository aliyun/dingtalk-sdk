<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 创建数据的应用id。
     *
     * @var string
     */
    public $dataCreateAppId;

    /**
     * @description 创建数据的应用类型，isv应用为premium_microapp。
     *
     * @var string
     */
    public $dataCreateAppType;

    /**
     * @description 数据创建时间。
     *
     * @var int
     */
    public $dataGmtCreate;

    /**
     * @description 数据最后修改时间。
     *
     * @var int
     */
    public $dataGmtModified;

    /**
     * @description 最后修改数据的应用id。
     *
     * @var string
     */
    public $dataModifiedAppId;

    /**
     * @description 最后修改数据的应用类型，取值同dataCreateAppType。
     *
     * @var string
     */
    public $dataModifiedAppType;

    /**
     * @description 数据完整内容。
     *
     * @var string
     */
    public $jsonData;
    protected $_name = [
        'dataCreateAppId'     => 'dataCreateAppId',
        'dataCreateAppType'   => 'dataCreateAppType',
        'dataGmtCreate'       => 'dataGmtCreate',
        'dataGmtModified'     => 'dataGmtModified',
        'dataModifiedAppId'   => 'dataModifiedAppId',
        'dataModifiedAppType' => 'dataModifiedAppType',
        'jsonData'            => 'jsonData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataCreateAppId) {
            $res['dataCreateAppId'] = $this->dataCreateAppId;
        }
        if (null !== $this->dataCreateAppType) {
            $res['dataCreateAppType'] = $this->dataCreateAppType;
        }
        if (null !== $this->dataGmtCreate) {
            $res['dataGmtCreate'] = $this->dataGmtCreate;
        }
        if (null !== $this->dataGmtModified) {
            $res['dataGmtModified'] = $this->dataGmtModified;
        }
        if (null !== $this->dataModifiedAppId) {
            $res['dataModifiedAppId'] = $this->dataModifiedAppId;
        }
        if (null !== $this->dataModifiedAppType) {
            $res['dataModifiedAppType'] = $this->dataModifiedAppType;
        }
        if (null !== $this->jsonData) {
            $res['jsonData'] = $this->jsonData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataCreateAppId'])) {
            $model->dataCreateAppId = $map['dataCreateAppId'];
        }
        if (isset($map['dataCreateAppType'])) {
            $model->dataCreateAppType = $map['dataCreateAppType'];
        }
        if (isset($map['dataGmtCreate'])) {
            $model->dataGmtCreate = $map['dataGmtCreate'];
        }
        if (isset($map['dataGmtModified'])) {
            $model->dataGmtModified = $map['dataGmtModified'];
        }
        if (isset($map['dataModifiedAppId'])) {
            $model->dataModifiedAppId = $map['dataModifiedAppId'];
        }
        if (isset($map['dataModifiedAppType'])) {
            $model->dataModifiedAppType = $map['dataModifiedAppType'];
        }
        if (isset($map['jsonData'])) {
            $model->jsonData = $map['jsonData'];
        }

        return $model;
    }
}
