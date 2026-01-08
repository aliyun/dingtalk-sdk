<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySummaryWithTemplateRequest extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $diyTemplateVersion;

    /**
     * @description This parameter is required.
     *
     * @example meeting-assistant
     *
     * @var string
     */
    public $summaryTemplateId;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var string
     */
    public $summaryTemplateType;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'diyTemplateVersion' => 'diyTemplateVersion',
        'summaryTemplateId' => 'summaryTemplateId',
        'summaryTemplateType' => 'summaryTemplateType',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->diyTemplateVersion) {
            $res['diyTemplateVersion'] = $this->diyTemplateVersion;
        }
        if (null !== $this->summaryTemplateId) {
            $res['summaryTemplateId'] = $this->summaryTemplateId;
        }
        if (null !== $this->summaryTemplateType) {
            $res['summaryTemplateType'] = $this->summaryTemplateType;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySummaryWithTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['diyTemplateVersion'])) {
            $model->diyTemplateVersion = $map['diyTemplateVersion'];
        }
        if (isset($map['summaryTemplateId'])) {
            $model->summaryTemplateId = $map['summaryTemplateId'];
        }
        if (isset($map['summaryTemplateType'])) {
            $model->summaryTemplateType = $map['summaryTemplateType'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
