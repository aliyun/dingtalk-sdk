<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileTemplateListRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example CONTRACT
     *
     * @var string
     */
    public $signSource;

    /**
     * @example 1
     *
     * @var int
     */
    public $templateStatus;

    /**
     * @var string[]
     */
    public $templateTypeList;
    protected $_name = [
        'maxResults'       => 'maxResults',
        'nextToken'        => 'nextToken',
        'signSource'       => 'signSource',
        'templateStatus'   => 'templateStatus',
        'templateTypeList' => 'templateTypeList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->signSource) {
            $res['signSource'] = $this->signSource;
        }
        if (null !== $this->templateStatus) {
            $res['templateStatus'] = $this->templateStatus;
        }
        if (null !== $this->templateTypeList) {
            $res['templateTypeList'] = $this->templateTypeList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileTemplateListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['signSource'])) {
            $model->signSource = $map['signSource'];
        }
        if (isset($map['templateStatus'])) {
            $model->templateStatus = $map['templateStatus'];
        }
        if (isset($map['templateTypeList'])) {
            if (!empty($map['templateTypeList'])) {
                $model->templateTypeList = $map['templateTypeList'];
            }
        }

        return $model;
    }
}
