<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabDataResponseBody\relatedViewTabDataResponse;
use AlibabaCloud\Tea\Model;

class GetRelatedViewTabDataResponseBody extends Model
{
    /**
     * @var relatedViewTabDataResponse
     */
    public $relatedViewTabDataResponse;
    protected $_name = [
        'relatedViewTabDataResponse' => 'relatedViewTabDataResponse',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relatedViewTabDataResponse) {
            $res['relatedViewTabDataResponse'] = null !== $this->relatedViewTabDataResponse ? $this->relatedViewTabDataResponse->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRelatedViewTabDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relatedViewTabDataResponse'])) {
            $model->relatedViewTabDataResponse = relatedViewTabDataResponse::fromMap($map['relatedViewTabDataResponse']);
        }

        return $model;
    }
}
