<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\UpdateHrmLegalEntityWithoutNameResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding123
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2023-01-01
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @example 2023-01-01
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @example 123456
     *
     * @var string
     */
    public $legalEntityId;

    /**
     * @example 公司1
     *
     * @var string
     */
    public $legalEntityName;

    /**
     * @example 公1
     *
     * @var string
     */
    public $legalEntityShortName;

    /**
     * @example 1
     *
     * @var int
     */
    public $legalEntityStatus;

    /**
     * @example 法人
     *
     * @var string
     */
    public $legalPersonName;
    protected $_name = [
        'corpId'               => 'corpId',
        'gmtCreate'            => 'gmtCreate',
        'gmtModified'          => 'gmtModified',
        'legalEntityId'        => 'legalEntityId',
        'legalEntityName'      => 'legalEntityName',
        'legalEntityShortName' => 'legalEntityShortName',
        'legalEntityStatus'    => 'legalEntityStatus',
        'legalPersonName'      => 'legalPersonName',
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
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->legalEntityId) {
            $res['legalEntityId'] = $this->legalEntityId;
        }
        if (null !== $this->legalEntityName) {
            $res['legalEntityName'] = $this->legalEntityName;
        }
        if (null !== $this->legalEntityShortName) {
            $res['legalEntityShortName'] = $this->legalEntityShortName;
        }
        if (null !== $this->legalEntityStatus) {
            $res['legalEntityStatus'] = $this->legalEntityStatus;
        }
        if (null !== $this->legalPersonName) {
            $res['legalPersonName'] = $this->legalPersonName;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['legalEntityId'])) {
            $model->legalEntityId = $map['legalEntityId'];
        }
        if (isset($map['legalEntityName'])) {
            $model->legalEntityName = $map['legalEntityName'];
        }
        if (isset($map['legalEntityShortName'])) {
            $model->legalEntityShortName = $map['legalEntityShortName'];
        }
        if (isset($map['legalEntityStatus'])) {
            $model->legalEntityStatus = $map['legalEntityStatus'];
        }
        if (isset($map['legalPersonName'])) {
            $model->legalPersonName = $map['legalPersonName'];
        }

        return $model;
    }
}
