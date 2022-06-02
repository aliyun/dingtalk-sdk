<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExclusiveCreateDingPortalRequest extends Model
{
    /**
     * @description 工作台名称。
     *
     * @var string
     */
    public $dingPortalName;

    /**
     * @description 被操纵企业ID。
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @description 模版id。
     *
     * @var string
     */
    public $templateAppUuid;

    /**
     * @description 模版所属的组织id。
     *
     * @var string
     */
    public $templateCorpId;
    protected $_name = [
        'dingPortalName'  => 'dingPortalName',
        'targetCorpId'    => 'targetCorpId',
        'templateAppUuid' => 'templateAppUuid',
        'templateCorpId'  => 'templateCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingPortalName) {
            $res['dingPortalName'] = $this->dingPortalName;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->templateAppUuid) {
            $res['templateAppUuid'] = $this->templateAppUuid;
        }
        if (null !== $this->templateCorpId) {
            $res['templateCorpId'] = $this->templateCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExclusiveCreateDingPortalRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingPortalName'])) {
            $model->dingPortalName = $map['dingPortalName'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['templateAppUuid'])) {
            $model->templateAppUuid = $map['templateAppUuid'];
        }
        if (isset($map['templateCorpId'])) {
            $model->templateCorpId = $map['templateCorpId'];
        }

        return $model;
    }
}
