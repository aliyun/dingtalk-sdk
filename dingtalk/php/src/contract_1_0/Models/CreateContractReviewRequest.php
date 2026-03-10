<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractReviewRequest\fileInfo;
use AlibabaCloud\Tea\Model;

class CreateContractReviewRequest extends Model
{
    /**
     * @var string[]
     */
    public $companyList;

    /**
     * @var string
     */
    public $customReviewRules;

    /**
     * @var fileInfo
     */
    public $fileInfo;

    /**
     * @var string
     */
    public $originatorUserId;

    /**
     * @var string
     */
    public $reviewPosition;

    /**
     * @var string
     */
    public $reviewResultType;

    /**
     * @var string
     */
    public $reviewType;
    protected $_name = [
        'companyList' => 'companyList',
        'customReviewRules' => 'customReviewRules',
        'fileInfo' => 'fileInfo',
        'originatorUserId' => 'originatorUserId',
        'reviewPosition' => 'reviewPosition',
        'reviewResultType' => 'reviewResultType',
        'reviewType' => 'reviewType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyList) {
            $res['companyList'] = $this->companyList;
        }
        if (null !== $this->customReviewRules) {
            $res['customReviewRules'] = $this->customReviewRules;
        }
        if (null !== $this->fileInfo) {
            $res['fileInfo'] = null !== $this->fileInfo ? $this->fileInfo->toMap() : null;
        }
        if (null !== $this->originatorUserId) {
            $res['originatorUserId'] = $this->originatorUserId;
        }
        if (null !== $this->reviewPosition) {
            $res['reviewPosition'] = $this->reviewPosition;
        }
        if (null !== $this->reviewResultType) {
            $res['reviewResultType'] = $this->reviewResultType;
        }
        if (null !== $this->reviewType) {
            $res['reviewType'] = $this->reviewType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateContractReviewRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyList'])) {
            if (!empty($map['companyList'])) {
                $model->companyList = $map['companyList'];
            }
        }
        if (isset($map['customReviewRules'])) {
            $model->customReviewRules = $map['customReviewRules'];
        }
        if (isset($map['fileInfo'])) {
            $model->fileInfo = fileInfo::fromMap($map['fileInfo']);
        }
        if (isset($map['originatorUserId'])) {
            $model->originatorUserId = $map['originatorUserId'];
        }
        if (isset($map['reviewPosition'])) {
            $model->reviewPosition = $map['reviewPosition'];
        }
        if (isset($map['reviewResultType'])) {
            $model->reviewResultType = $map['reviewResultType'];
        }
        if (isset($map['reviewType'])) {
            $model->reviewType = $map['reviewType'];
        }

        return $model;
    }
}
