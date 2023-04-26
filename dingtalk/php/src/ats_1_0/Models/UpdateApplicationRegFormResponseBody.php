<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateApplicationRegFormResponseBody extends Model
{
    /**
     * @example manager5875
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example formXXX
     *
     * @var string
     */
    public $formId;

    /**
     * @example 1626775016427
     *
     * @var int
     */
    public $gmtCreateMillis;

    /**
     * @example 1626775016427
     *
     * @var int
     */
    public $gmtModifiedMillis;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @example templateXXX
     *
     * @var string
     */
    public $templateId;

    /**
     * @example 0
     *
     * @var int
     */
    public $templateVersion;
    protected $_name = [
        'creatorUserId'     => 'creatorUserId',
        'formId'            => 'formId',
        'gmtCreateMillis'   => 'gmtCreateMillis',
        'gmtModifiedMillis' => 'gmtModifiedMillis',
        'status'            => 'status',
        'templateId'        => 'templateId',
        'templateVersion'   => 'templateVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
        }
        if (null !== $this->gmtCreateMillis) {
            $res['gmtCreateMillis'] = $this->gmtCreateMillis;
        }
        if (null !== $this->gmtModifiedMillis) {
            $res['gmtModifiedMillis'] = $this->gmtModifiedMillis;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateVersion) {
            $res['templateVersion'] = $this->templateVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateApplicationRegFormResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
        }
        if (isset($map['gmtCreateMillis'])) {
            $model->gmtCreateMillis = $map['gmtCreateMillis'];
        }
        if (isset($map['gmtModifiedMillis'])) {
            $model->gmtModifiedMillis = $map['gmtModifiedMillis'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateVersion'])) {
            $model->templateVersion = $map['templateVersion'];
        }

        return $model;
    }
}
