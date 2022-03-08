<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesResponseBody\result\values\formInstDataList;
use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @description 应用搭建id
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 扩展信息
     *
     * @var mixed[]
     */
    public $attributes;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @description 创建人
     *
     * @var string
     */
    public $creator;

    /**
     * @description 表单模板code
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单实例数据
     *
     * @var formInstDataList[]
     */
    public $formInstDataList;

    /**
     * @description 表单实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 修改人
     *
     * @var string
     */
    public $modifier;

    /**
     * @description 修改时间
     *
     * @var int
     */
    public $modifyTimestamp;

    /**
     * @description 外部业务编码
     *
     * @var string
     */
    public $outBizCode;

    /**
     * @description 外部实例编码
     *
     * @var string
     */
    public $outInstanceId;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'appUuid'          => 'appUuid',
        'attributes'       => 'attributes',
        'createTimestamp'  => 'createTimestamp',
        'creator'          => 'creator',
        'formCode'         => 'formCode',
        'formInstDataList' => 'formInstDataList',
        'formInstanceId'   => 'formInstanceId',
        'modifier'         => 'modifier',
        'modifyTimestamp'  => 'modifyTimestamp',
        'outBizCode'       => 'outBizCode',
        'outInstanceId'    => 'outInstanceId',
        'title'            => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->createTimestamp) {
            $res['createTimestamp'] = $this->createTimestamp;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
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
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->modifyTimestamp) {
            $res['modifyTimestamp'] = $this->modifyTimestamp;
        }
        if (null !== $this->outBizCode) {
            $res['outBizCode'] = $this->outBizCode;
        }
        if (null !== $this->outInstanceId) {
            $res['outInstanceId'] = $this->outInstanceId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return values
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['createTimestamp'])) {
            $model->createTimestamp = $map['createTimestamp'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
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
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['modifyTimestamp'])) {
            $model->modifyTimestamp = $map['modifyTimestamp'];
        }
        if (isset($map['outBizCode'])) {
            $model->outBizCode = $map['outBizCode'];
        }
        if (isset($map['outInstanceId'])) {
            $model->outInstanceId = $map['outInstanceId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
