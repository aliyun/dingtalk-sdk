<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;

use AlibabaCloud\Tea\Model;

class syncCollabSheetConfig extends Model
{
    /**
     * @var string[]
     */
    public $agentPromptTemplateIds;

    /**
     * @var string
     */
    public $collabSheetName;

    /**
     * @var string
     */
    public $collabSheetUrl;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $dentryUuid;

    /**
     * @var string
     */
    public $sheetId;

    /**
     * @var bool
     */
    public $syncCollabSheet;
    protected $_name = [
        'agentPromptTemplateIds' => 'agentPromptTemplateIds',
        'collabSheetName' => 'collabSheetName',
        'collabSheetUrl' => 'collabSheetUrl',
        'corpId' => 'corpId',
        'dentryUuid' => 'dentryUuid',
        'sheetId' => 'sheetId',
        'syncCollabSheet' => 'syncCollabSheet',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentPromptTemplateIds) {
            $res['agentPromptTemplateIds'] = $this->agentPromptTemplateIds;
        }
        if (null !== $this->collabSheetName) {
            $res['collabSheetName'] = $this->collabSheetName;
        }
        if (null !== $this->collabSheetUrl) {
            $res['collabSheetUrl'] = $this->collabSheetUrl;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->sheetId) {
            $res['sheetId'] = $this->sheetId;
        }
        if (null !== $this->syncCollabSheet) {
            $res['syncCollabSheet'] = $this->syncCollabSheet;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return syncCollabSheetConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentPromptTemplateIds'])) {
            if (!empty($map['agentPromptTemplateIds'])) {
                $model->agentPromptTemplateIds = $map['agentPromptTemplateIds'];
            }
        }
        if (isset($map['collabSheetName'])) {
            $model->collabSheetName = $map['collabSheetName'];
        }
        if (isset($map['collabSheetUrl'])) {
            $model->collabSheetUrl = $map['collabSheetUrl'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['sheetId'])) {
            $model->sheetId = $map['sheetId'];
        }
        if (isset($map['syncCollabSheet'])) {
            $model->syncCollabSheet = $map['syncCollabSheet'];
        }

        return $model;
    }
}
