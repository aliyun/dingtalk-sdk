<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSearchItemsByKeyWordRequest extends Model
{
    /**
     * @description 搜索关键词
     *
     * @var string
     */
    public $keyWord;

    /**
     * @description 加密偏移量，第一次请求取“0”值，后续请求根据接口返回的nextToken值进行填写
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 一次性请求的item数量
     *
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'keyWord'    => 'keyWord',
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyWord) {
            $res['keyWord'] = $this->keyWord;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSearchItemsByKeyWordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyWord'])) {
            $model->keyWord = $map['keyWord'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }

        return $model;
    }
}
