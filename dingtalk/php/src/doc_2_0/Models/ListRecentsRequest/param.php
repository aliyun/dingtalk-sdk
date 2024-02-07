<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @example 0
     *
     * @var int[]
     */
    public $fileTypes;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example nextToken
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 0
     *
     * @var int[]
     */
    public $operateTypes;
    protected $_name = [
        'fileTypes'    => 'fileTypes',
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'operateTypes' => 'operateTypes',
    ];

    public function validate()
    {
    }

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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
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

        return $model;
    }
}
