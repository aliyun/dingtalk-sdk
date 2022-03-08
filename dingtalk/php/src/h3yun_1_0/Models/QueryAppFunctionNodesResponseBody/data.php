<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryAppFunctionNodesResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 节点所属的应用编码
     *
     * @var string
     */
    public $appCode;

    /**
     * @description 显示名称
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 是否是系统节点，如果是则无法删除
     *
     * @var bool
     */
    public $isSystem;

    /**
     * @description 菜单节点类型。 AppPackage=应用程序 FormModule=列表模块(不能发起流程)、 WorkflowModule=流程列表模块(可以发起流程) ReportModule=报表模块 GroupModule=节点分组
     *
     * @var string
     */
    public $nodeType;

    /**
     * @description 菜单可见类型。 Inactive=未指定 AllVisible=全部可见 PcVisible=仅pc可见 MobileVisible=仅移动端可见 InVisible=全部不可见
     *
     * @var string
     */
    public $nodeVisibleType;

    /**
     * @description 父节点的编码
     *
     * @var string
     */
    public $parentCode;

    /**
     * @description 节点编码。如果nodeType=FormModule,则为表单编码
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @description 排序编号
     *
     * @var int
     */
    public $sortKey;

    /**
     * @description 菜单状态。 Inactive=未激活 Active=激活
     *
     * @var string
     */
    public $state;
    protected $_name = [
        'appCode'         => 'appCode',
        'displayName'     => 'displayName',
        'isSystem'        => 'isSystem',
        'nodeType'        => 'nodeType',
        'nodeVisibleType' => 'nodeVisibleType',
        'parentCode'      => 'parentCode',
        'schemaCode'      => 'schemaCode',
        'sortKey'         => 'sortKey',
        'state'           => 'state',
    ];

    public function validate()
    {
    }

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
