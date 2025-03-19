<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmLegalEntityRequest\ext;
use AlibabaCloud\Tea\Model;

class AddHrmLegalEntityRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $createUserId;

    /**
     * @var ext
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $legalEntityName;

    /**
     * @var string
     */
    public $legalEntityShortName;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $legalEntityStatus;

    /**
     * @var string
     */
    public $legalPersonName;

    /**
     * @var int
     */
    public $dingTenantId;
    protected $_name = [
        'corpId' => 'corpId',
        'createUserId' => 'createUserId',
        'ext' => 'ext',
        'legalEntityName' => 'legalEntityName',
        'legalEntityShortName' => 'legalEntityShortName',
        'legalEntityStatus' => 'legalEntityStatus',
        'legalPersonName' => 'legalPersonName',
        'dingTenantId' => 'dingTenantId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createUserId) {
            $res['createUserId'] = $this->createUserId;
        }
        if (null !== $this->ext) {
            $res['ext'] = null !== $this->ext ? $this->ext->toMap() : null;
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
        if (null !== $this->dingTenantId) {
            $res['dingTenantId'] = $this->dingTenantId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddHrmLegalEntityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createUserId'])) {
            $model->createUserId = $map['createUserId'];
        }
        if (isset($map['ext'])) {
            $model->ext = ext::fromMap($map['ext']);
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
        if (isset($map['dingTenantId'])) {
            $model->dingTenantId = $map['dingTenantId'];
        }

        return $model;
    }
}
