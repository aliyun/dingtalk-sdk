<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListRecentsRequest extends Model
{
    /**
     * @var int[]
     */
    public $fileTypes;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var int[]
     */
    public $operateTypes;

    /**
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'fileTypes' => 'fileTypes',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'operateTypes' => 'operateTypes',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileTypes) {
            $res['fileTypes'] = $this->fileTypes;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operateTypes) {
            $res['operateTypes'] = $this->operateTypes;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRecentsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileTypes'])) {
            if (!empty($map['fileTypes'])) {
                $model->fileTypes = $map['fileTypes'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operateTypes'])) {
            if (!empty($map['operateTypes'])) {
                $model->operateTypes = $map['operateTypes'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
