<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFormSchemaResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFormSchemaResponseBody\result\schemaContent;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $appType;

    /**
     * @description This parameter is required.
     *
     * @example 26652461xxxx5992
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description This parameter is required.
     *
     * @example PROC-17428B8C-6C60-470E-xxxx-64F1037AE067
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @example 2021-12-01T10:49Z
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 2021-12-01T10:49Z
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example null
     *
     * @var string
     */
    public $icon;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $memo;

    /**
     * @example 示例模板
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var schemaContent
     */
    public $schemaContent;

    /**
     * @example PUBLISHED
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'appType'       => 'appType',
        'creatorUserId' => 'creatorUserId',
        'formCode'      => 'formCode',
        'gmtCreate'     => 'gmtCreate',
        'gmtModified'   => 'gmtModified',
        'icon'          => 'icon',
        'memo'          => 'memo',
        'name'          => 'name',
        'schemaContent' => 'schemaContent',
        'status'        => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = null !== $this->schemaContent ? $this->schemaContent->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = schemaContent::fromMap($map['schemaContent']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
