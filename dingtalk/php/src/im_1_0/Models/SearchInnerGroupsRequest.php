<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchInnerGroupsRequest extends Model
{
    /**
     * @description 查询最大数量。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 关键词。
     *
     * @var string
     */
    public $searchKey;

    /**
     * @description 用户userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'searchKey'  => 'searchKey',
        'userId'     => 'userId',
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
        if (null !== $this->searchKey) {
            $res['searchKey'] = $this->searchKey;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchInnerGroupsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['searchKey'])) {
            $model->searchKey = $map['searchKey'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
