<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\GetTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var mixed
     */
    public $commonVariableList;

    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var mixed
     */
    public $expVariableList;

    /**
     * @var string
     */
    public $extendType;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var mixed
     */
    public $localVariableList;

    /**
     * @var string
     */
    public $miniAppId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $preview;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'commonVariableList' => 'commonVariableList',
        'creatorId' => 'creatorId',
        'expVariableList' => 'expVariableList',
        'extendType' => 'extendType',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'localVariableList' => 'localVariableList',
        'miniAppId' => 'miniAppId',
        'name' => 'name',
        'preview' => 'preview',
        'status' => 'status',
        'templateId' => 'templateId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commonVariableList) {
            $res['commonVariableList'] = $this->commonVariableList;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->expVariableList) {
            $res['expVariableList'] = $this->expVariableList;
        }
        if (null !== $this->extendType) {
            $res['extendType'] = $this->extendType;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->localVariableList) {
            $res['localVariableList'] = $this->localVariableList;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->preview) {
            $res['preview'] = $this->preview;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['commonVariableList'])) {
            $model->commonVariableList = $map['commonVariableList'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['expVariableList'])) {
            $model->expVariableList = $map['expVariableList'];
        }
        if (isset($map['extendType'])) {
            $model->extendType = $map['extendType'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['localVariableList'])) {
            $model->localVariableList = $map['localVariableList'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['preview'])) {
            $model->preview = $map['preview'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
