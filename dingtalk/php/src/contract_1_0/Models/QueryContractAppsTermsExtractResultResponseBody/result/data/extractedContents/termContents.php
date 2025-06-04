<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsTermsExtractResultResponseBody\result\data\extractedContents;

use AlibabaCloud\Tea\Model;

class termContents extends Model
{
    /**
     * @var string
     */
    public $detailTerm;

    /**
     * @var string
     */
    public $exist;

    /**
     * @var string
     */
    public $shortTerm;

    /**
     * @var string
     */
    public $termCategory;
    protected $_name = [
        'detailTerm' => 'detailTerm',
        'exist' => 'exist',
        'shortTerm' => 'shortTerm',
        'termCategory' => 'termCategory',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailTerm) {
            $res['detailTerm'] = $this->detailTerm;
        }
        if (null !== $this->exist) {
            $res['exist'] = $this->exist;
        }
        if (null !== $this->shortTerm) {
            $res['shortTerm'] = $this->shortTerm;
        }
        if (null !== $this->termCategory) {
            $res['termCategory'] = $this->termCategory;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return termContents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailTerm'])) {
            $model->detailTerm = $map['detailTerm'];
        }
        if (isset($map['exist'])) {
            $model->exist = $map['exist'];
        }
        if (isset($map['shortTerm'])) {
            $model->shortTerm = $map['shortTerm'];
        }
        if (isset($map['termCategory'])) {
            $model->termCategory = $map['termCategory'];
        }

        return $model;
    }
}
