<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkspaceDocRequest extends Model
{
    /**
     * @var string
     */
    public $docType;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var string
     */
    public $parentNodeId;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $templateType;
    protected $_name = [
        'docType'      => 'docType',
        'name'         => 'name',
        'operatorId'   => 'operatorId',
        'parentNodeId' => 'parentNodeId',
        'templateId'   => 'templateId',
        'templateType' => 'templateType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docType) {
            $res['docType'] = $this->docType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->parentNodeId) {
            $res['parentNodeId'] = $this->parentNodeId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateType) {
            $res['templateType'] = $this->templateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkspaceDocRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docType'])) {
            $model->docType = $map['docType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['parentNodeId'])) {
            $model->parentNodeId = $map['parentNodeId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateType'])) {
            $model->templateType = $map['templateType'];
        }

        return $model;
    }
}
