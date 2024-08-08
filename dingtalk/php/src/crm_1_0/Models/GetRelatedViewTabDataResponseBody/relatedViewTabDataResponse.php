<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabDataResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabDataResponseBody\relatedViewTabDataResponse\relatedViewTabPageData;
use AlibabaCloud\Tea\Model;

class relatedViewTabDataResponse extends Model
{
    /**
     * @var relatedViewTabPageData
     */
    public $relatedViewTabPageData;
    protected $_name = [
        'relatedViewTabPageData' => 'relatedViewTabPageData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relatedViewTabPageData) {
            $res['relatedViewTabPageData'] = null !== $this->relatedViewTabPageData ? $this->relatedViewTabPageData->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relatedViewTabDataResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relatedViewTabPageData'])) {
            $model->relatedViewTabPageData = relatedViewTabPageData::fromMap($map['relatedViewTabPageData']);
        }

        return $model;
    }
}
