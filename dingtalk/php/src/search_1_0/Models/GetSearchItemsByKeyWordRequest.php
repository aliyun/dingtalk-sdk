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
     * @description 一次性请求的item数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 加密偏移量，第一次请求取“0”值，后续请求根据接口返回的nextToken值进行填写
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'keyWord'    => 'keyWord',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
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
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
