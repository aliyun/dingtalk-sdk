<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormInstanceResponseBody\formInstDataList;
use AlibabaCloud\Tea\Model;

class QueryFormInstanceResponseBody extends Model
{
    /**
     * @description 实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 表单数据
     *
     * @var formInstDataList[]
     */
    public $formInstDataList;

    /**
     * @description 应用搭建id
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 表单模板id
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 创建人
     *
     * @var string
     */
    public $creator;

    /**
     * @description 修改人
     *
     * @var string
     */
    public $modifier;

    /**
     * @description 实例创建时间戳
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @description 实例最近修改时间戳
     *
     * @var int
     */
    public $modifyTimestamp;

    /**
     * @description 外联业务实例id
     *
     * @var string
     */
    public $outInstanceId;

    /**
     * @description 外联业务code
     *
     * @var string
     */
    public $outBizCode;

    /**
     * @description 扩展信息
     *
     * @var mixed[]
     */
    public $attributes;
    protected $_name = [
        'formInstanceId'   => 'formInstanceId',
        'formInstDataList' => 'formInstDataList',
        'appUuid'          => 'appUuid',
        'formCode'         => 'formCode',
        'title'            => 'title',
        'creator'          => 'creator',
        'modifier'         => 'modifier',
        'createTimestamp'  => 'createTimestamp',
        'modifyTimestamp'  => 'modifyTimestamp',
        'outInstanceId'    => 'outInstanceId',
        'outBizCode'       => 'outBizCode',
        'attributes'       => 'attributes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formInstDataList) {
            $res['formInstDataList'] = [];
            if (null !== $this->formInstDataList && \is_array($this->formInstDataList)) {
                $n = 0;
                foreach ($this->formInstDataList as $item) {
                    $res['formInstDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->createTimestamp) {
            $res['createTimestamp'] = $this->createTimestamp;
        }
        if (null !== $this->modifyTimestamp) {
            $res['modifyTimestamp'] = $this->modifyTimestamp;
        }
        if (null !== $this->outInstanceId) {
            $res['outInstanceId'] = $this->outInstanceId;
        }
        if (null !== $this->outBizCode) {
            $res['outBizCode'] = $this->outBizCode;
        }
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFormInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formInstDataList'])) {
            if (!empty($map['formInstDataList'])) {
                $model->formInstDataList = [];
                $n                       = 0;
                foreach ($map['formInstDataList'] as $item) {
                    $model->formInstDataList[$n++] = null !== $item ? formInstDataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['createTimestamp'])) {
            $model->createTimestamp = $map['createTimestamp'];
        }
        if (isset($map['modifyTimestamp'])) {
            $model->modifyTimestamp = $map['modifyTimestamp'];
        }
        if (isset($map['outInstanceId'])) {
            $model->outInstanceId = $map['outInstanceId'];
        }
        if (isset($map['outBizCode'])) {
            $model->outBizCode = $map['outBizCode'];
        }
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }

        return $model;
    }
}
