<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest\dentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest\spaceRequest;
use AlibabaCloud\Tea\Model;

class SearchRequest extends Model
{
    /**
     * @var dentryRequest
     */
    public $dentryRequest;

    /**
     * @example 测试搜索关键词
     *
     * @var string
     */
    public $keyword;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var spaceRequest
     */
    public $spaceRequest;
    protected $_name = [
        'dentryRequest' => 'dentryRequest',
        'keyword'       => 'keyword',
        'operatorId'    => 'operatorId',
        'spaceRequest'  => 'spaceRequest',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryRequest) {
            $res['dentryRequest'] = null !== $this->dentryRequest ? $this->dentryRequest->toMap() : null;
        }
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->spaceRequest) {
            $res['spaceRequest'] = null !== $this->spaceRequest ? $this->spaceRequest->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryRequest'])) {
            $model->dentryRequest = dentryRequest::fromMap($map['dentryRequest']);
        }
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['spaceRequest'])) {
            $model->spaceRequest = spaceRequest::fromMap($map['spaceRequest']);
        }

        return $model;
    }
}
