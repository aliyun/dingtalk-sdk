<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody;

use AlibabaCloud\Tea\Model;

class template extends Model
{
    /**
     * @description 工单模版业务ID
     *
     * @var string
     */
    public $openTemplateBizId;

    /**
     * @description 工单模版ID
     *
     * @var string
     */
    public $openTemplateId;

    /**
     * @description 工单模版名称
     *
     * @var string
     */
    public $templateName;
    protected $_name = [
        'openTemplateBizId' => 'openTemplateBizId',
        'openTemplateId'    => 'openTemplateId',
        'templateName'      => 'templateName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTemplateBizId) {
            $res['openTemplateBizId'] = $this->openTemplateBizId;
        }
        if (null !== $this->openTemplateId) {
            $res['openTemplateId'] = $this->openTemplateId;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return template
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTemplateBizId'])) {
            $model->openTemplateBizId = $map['openTemplateBizId'];
        }
        if (isset($map['openTemplateId'])) {
            $model->openTemplateId = $map['openTemplateId'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }

        return $model;
    }
}
