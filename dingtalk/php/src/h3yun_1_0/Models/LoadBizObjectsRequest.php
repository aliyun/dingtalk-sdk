<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsRequest\sortByFields;
use AlibabaCloud\Tea\Model;

class LoadBizObjectsRequest extends Model
{
    /**
     * @example {     "Type": "Item",     "Name": "F0000010",     "Operator": 2,     "Value": "0000007" }
     *
     * @var string
     */
    public $matcherJson;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @var string[]
     */
    public $returnFields;

    /**
     * @description This parameter is required.
     *
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @var sortByFields[]
     */
    public $sortByFields;
    protected $_name = [
        'matcherJson'  => 'matcherJson',
        'pageNumber'   => 'pageNumber',
        'pageSize'     => 'pageSize',
        'returnFields' => 'returnFields',
        'schemaCode'   => 'schemaCode',
        'sortByFields' => 'sortByFields',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->matcherJson) {
            $res['matcherJson'] = $this->matcherJson;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->returnFields) {
            $res['returnFields'] = $this->returnFields;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }
        if (null !== $this->sortByFields) {
            $res['sortByFields'] = [];
            if (null !== $this->sortByFields && \is_array($this->sortByFields)) {
                $n = 0;
                foreach ($this->sortByFields as $item) {
                    $res['sortByFields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LoadBizObjectsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['matcherJson'])) {
            $model->matcherJson = $map['matcherJson'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['returnFields'])) {
            if (!empty($map['returnFields'])) {
                $model->returnFields = $map['returnFields'];
            }
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }
        if (isset($map['sortByFields'])) {
            if (!empty($map['sortByFields'])) {
                $model->sortByFields = [];
                $n                   = 0;
                foreach ($map['sortByFields'] as $item) {
                    $model->sortByFields[$n++] = null !== $item ? sortByFields::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
