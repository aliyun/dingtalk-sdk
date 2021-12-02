<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryEduAssetSpacesRequest extends Model
{
    /**
     * @description 标记当前开始读取的位置，置空表示从头开始
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 本次读取的最大数据记录数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 业务编码
     *
     * @var string
     */
    public $bizCode;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
        'bizCode'    => 'bizCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryEduAssetSpacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }

        return $model;
    }
}
