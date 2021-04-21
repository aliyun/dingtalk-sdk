<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSpacesRequest extends Model
{
    /**
     * @description 空间类型
     *
     * @var string
     */
    public $spaceType;

    /**
     * @description 分页加载锚点
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'spaceType'  => 'spaceType',
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
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
     * @return ListSpacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
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
