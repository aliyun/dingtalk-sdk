<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\dentryResult;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult;
use AlibabaCloud\Tea\Model;

class SearchResponseBody extends Model
{
    /**
     * @description 节点搜索结果。
     *
     * @var dentryResult
     */
    public $dentryResult;

    /**
     * @description 知识库搜索结果。
     *
     * @var spaceResult
     */
    public $spaceResult;
    protected $_name = [
        'dentryResult' => 'dentryResult',
        'spaceResult'  => 'spaceResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryResult) {
            $res['dentryResult'] = null !== $this->dentryResult ? $this->dentryResult->toMap() : null;
        }
        if (null !== $this->spaceResult) {
            $res['spaceResult'] = null !== $this->spaceResult ? $this->spaceResult->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryResult'])) {
            $model->dentryResult = dentryResult::fromMap($map['dentryResult']);
        }
        if (isset($map['spaceResult'])) {
            $model->spaceResult = spaceResult::fromMap($map['spaceResult']);
        }

        return $model;
    }
}
