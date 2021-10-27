<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesResponseBody\result\values\formInstDataList;
use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @description 表单实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 应用搭建id
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 表单模板code
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 标题
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
     * @description 创建时间
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @description 修改时间
     *
     * @var int
     */
    public $modifyTimestamp;

    /**
     * @description 外部实例编码
     *
     * @var string
     */
    public $outInstanceId;

    /**
     * @description 外部业务编码
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

    /**
     * @description 表单实例数据
     *
     * @var formInstDataList[]
     */
    public $formInstDataList;
    protected $_name = [
        'formInstanceId'   => 'formInstanceId',
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
        'formInstDataList' => 'formInstDataList',
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
        if (null !== $this->formInstDataList) {
            $res['formInstDataList'] = [];
            if (null !== $this->formInstDataList && \is_array($this->formInstDataList)) {
                $n = 0;
                foreach ($this->formInstDataList as $item) {
                    $res['formInstDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
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
        if (isset($map['formInstDataList'])) {
            if (!empty($map['formInstDataList'])) {
                $model->formInstDataList = [];
                $n                       = 0;
                foreach ($map['formInstDataList'] as $item) {
                    $model->formInstDataList[$n++] = null !== $item ? formInstDataList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
