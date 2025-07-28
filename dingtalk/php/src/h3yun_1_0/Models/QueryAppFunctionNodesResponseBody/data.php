<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryAppFunctionNodesResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example D000001
     *
     * @var string
     */
    public $appCode;

    /**
     * @example 客户管理
     *
     * @var string
     */
    public $displayName;

    /**
     * @example false
     *
     * @var bool
     */
    public $isSystem;

    /**
     * @example FormModule
     *
     * @var string
     */
    public $nodeType;

    /**
     * @example AllVisible
     *
     * @var string
     */
    public $nodeVisibleType;

    /**
     * @example 6b42e223-c849-4fe9-9916-52f52d1a41b5
     *
     * @var string
     */
    public $parentCode;

    /**
     * @example 8d56c3b7-e996-4223-96a0-85ad16c11825
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @example 1000000011
     *
     * @var int
     */
    public $sortKey;

    /**
     * @example Active
     *
     * @var string
     */
    public $state;
    protected $_name = [
        'appCode' => 'appCode',
        'displayName' => 'displayName',
        'isSystem' => 'isSystem',
        'nodeType' => 'nodeType',
        'nodeVisibleType' => 'nodeVisibleType',
        'parentCode' => 'parentCode',
        'schemaCode' => 'schemaCode',
        'sortKey' => 'sortKey',
        'state' => 'state',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->isSystem) {
            $res['isSystem'] = $this->isSystem;
        }
        if (null !== $this->nodeType) {
            $res['nodeType'] = $this->nodeType;
        }
        if (null !== $this->nodeVisibleType) {
            $res['nodeVisibleType'] = $this->nodeVisibleType;
        }
        if (null !== $this->parentCode) {
            $res['parentCode'] = $this->parentCode;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }
        if (null !== $this->sortKey) {
            $res['sortKey'] = $this->sortKey;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['isSystem'])) {
            $model->isSystem = $map['isSystem'];
        }
        if (isset($map['nodeType'])) {
            $model->nodeType = $map['nodeType'];
        }
        if (isset($map['nodeVisibleType'])) {
            $model->nodeVisibleType = $map['nodeVisibleType'];
        }
        if (isset($map['parentCode'])) {
            $model->parentCode = $map['parentCode'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }
        if (isset($map['sortKey'])) {
            $model->sortKey = $map['sortKey'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
