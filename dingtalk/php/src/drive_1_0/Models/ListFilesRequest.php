<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFilesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $orderType;

    /**
     * @var string
     */
    public $parentId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;

    /**
     * @var bool
     */
    public $withIcon;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'orderType'  => 'orderType',
        'parentId'   => 'parentId',
        'unionId'    => 'unionId',
        'withIcon'   => 'withIcon',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->withIcon) {
            $res['withIcon'] = $this->withIcon;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFilesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['withIcon'])) {
            $model->withIcon = $map['withIcon'];
        }

        return $model;
    }
}
