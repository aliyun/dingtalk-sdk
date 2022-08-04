<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListFeedsRequest extends Model
{
    /**
     * @description 是否排除文件。
     *
     * @var bool
     */
    public $excludeFile;

    /**
     * @description 每页最大条目数，最大值50。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标，第一页可不传。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 操作用户unionId。
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'excludeFile' => 'excludeFile',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'operatorId'  => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->excludeFile) {
            $res['excludeFile'] = $this->excludeFile;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFeedsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['excludeFile'])) {
            $model->excludeFile = $map['excludeFile'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
