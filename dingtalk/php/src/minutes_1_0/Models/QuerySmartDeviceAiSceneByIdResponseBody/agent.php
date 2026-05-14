<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\deviceList;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\isvAiScene;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\llmModel;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\minutesTemplates;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\projectList;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\syncCollabSheetConfig;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\syncIsvSystemConfigs;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent\syncYidaConfig;
use AlibabaCloud\Tea\Model;

class agent extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $agentInstanceId;

    /**
     * @var string
     */
    public $agentName;

    /**
     * @var bool
     */
    public $allFileGroups;

    /**
     * @var mixed[]
     */
    public $attributes;

    /**
     * @var string
     */
    public $avatarUrl;

    /**
     * @var string
     */
    public $belongingId;

    /**
     * @var int
     */
    public $belongingType;

    /**
     * @var string
     */
    public $country;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var deviceList[]
     */
    public $deviceList;

    /**
     * @var isvAiScene
     */
    public $isvAiScene;

    /**
     * @var string[]
     */
    public $keywords;

    /**
     * @var llmModel
     */
    public $llmModel;

    /**
     * @var string
     */
    public $mail;

    /**
     * @var string
     */
    public $mailOption;

    /**
     * @var minutesTemplates[]
     */
    public $minutesTemplates;

    /**
     * @var projectList[]
     */
    public $projectList;

    /**
     * @var string
     */
    public $prompt;

    /**
     * @var string[]
     */
    public $promptTemplateIds;

    /**
     * @var int
     */
    public $state;

    /**
     * @var syncCollabSheetConfig
     */
    public $syncCollabSheetConfig;

    /**
     * @var syncIsvSystemConfigs[]
     */
    public $syncIsvSystemConfigs;

    /**
     * @var syncYidaConfig
     */
    public $syncYidaConfig;
    protected $_name = [
        'agentId' => 'agentId',
        'agentInstanceId' => 'agentInstanceId',
        'agentName' => 'agentName',
        'allFileGroups' => 'allFileGroups',
        'attributes' => 'attributes',
        'avatarUrl' => 'avatarUrl',
        'belongingId' => 'belongingId',
        'belongingType' => 'belongingType',
        'country' => 'country',
        'creatorUnionId' => 'creatorUnionId',
        'description' => 'description',
        'deviceList' => 'deviceList',
        'isvAiScene' => 'isvAiScene',
        'keywords' => 'keywords',
        'llmModel' => 'llmModel',
        'mail' => 'mail',
        'mailOption' => 'mailOption',
        'minutesTemplates' => 'minutesTemplates',
        'projectList' => 'projectList',
        'prompt' => 'prompt',
        'promptTemplateIds' => 'promptTemplateIds',
        'state' => 'state',
        'syncCollabSheetConfig' => 'syncCollabSheetConfig',
        'syncIsvSystemConfigs' => 'syncIsvSystemConfigs',
        'syncYidaConfig' => 'syncYidaConfig',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->agentInstanceId) {
            $res['agentInstanceId'] = $this->agentInstanceId;
        }
        if (null !== $this->agentName) {
            $res['agentName'] = $this->agentName;
        }
        if (null !== $this->allFileGroups) {
            $res['allFileGroups'] = $this->allFileGroups;
        }
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->belongingId) {
            $res['belongingId'] = $this->belongingId;
        }
        if (null !== $this->belongingType) {
            $res['belongingType'] = $this->belongingType;
        }
        if (null !== $this->country) {
            $res['country'] = $this->country;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->deviceList) {
            $res['deviceList'] = [];
            if (null !== $this->deviceList && \is_array($this->deviceList)) {
                $n = 0;
                foreach ($this->deviceList as $item) {
                    $res['deviceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isvAiScene) {
            $res['isvAiScene'] = null !== $this->isvAiScene ? $this->isvAiScene->toMap() : null;
        }
        if (null !== $this->keywords) {
            $res['keywords'] = $this->keywords;
        }
        if (null !== $this->llmModel) {
            $res['llmModel'] = null !== $this->llmModel ? $this->llmModel->toMap() : null;
        }
        if (null !== $this->mail) {
            $res['mail'] = $this->mail;
        }
        if (null !== $this->mailOption) {
            $res['mailOption'] = $this->mailOption;
        }
        if (null !== $this->minutesTemplates) {
            $res['minutesTemplates'] = [];
            if (null !== $this->minutesTemplates && \is_array($this->minutesTemplates)) {
                $n = 0;
                foreach ($this->minutesTemplates as $item) {
                    $res['minutesTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->projectList) {
            $res['projectList'] = [];
            if (null !== $this->projectList && \is_array($this->projectList)) {
                $n = 0;
                foreach ($this->projectList as $item) {
                    $res['projectList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->prompt) {
            $res['prompt'] = $this->prompt;
        }
        if (null !== $this->promptTemplateIds) {
            $res['promptTemplateIds'] = $this->promptTemplateIds;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->syncCollabSheetConfig) {
            $res['syncCollabSheetConfig'] = null !== $this->syncCollabSheetConfig ? $this->syncCollabSheetConfig->toMap() : null;
        }
        if (null !== $this->syncIsvSystemConfigs) {
            $res['syncIsvSystemConfigs'] = [];
            if (null !== $this->syncIsvSystemConfigs && \is_array($this->syncIsvSystemConfigs)) {
                $n = 0;
                foreach ($this->syncIsvSystemConfigs as $item) {
                    $res['syncIsvSystemConfigs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->syncYidaConfig) {
            $res['syncYidaConfig'] = null !== $this->syncYidaConfig ? $this->syncYidaConfig->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return agent
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['agentInstanceId'])) {
            $model->agentInstanceId = $map['agentInstanceId'];
        }
        if (isset($map['agentName'])) {
            $model->agentName = $map['agentName'];
        }
        if (isset($map['allFileGroups'])) {
            $model->allFileGroups = $map['allFileGroups'];
        }
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['belongingId'])) {
            $model->belongingId = $map['belongingId'];
        }
        if (isset($map['belongingType'])) {
            $model->belongingType = $map['belongingType'];
        }
        if (isset($map['country'])) {
            $model->country = $map['country'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['deviceList'])) {
            if (!empty($map['deviceList'])) {
                $model->deviceList = [];
                $n = 0;
                foreach ($map['deviceList'] as $item) {
                    $model->deviceList[$n++] = null !== $item ? deviceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isvAiScene'])) {
            $model->isvAiScene = isvAiScene::fromMap($map['isvAiScene']);
        }
        if (isset($map['keywords'])) {
            if (!empty($map['keywords'])) {
                $model->keywords = $map['keywords'];
            }
        }
        if (isset($map['llmModel'])) {
            $model->llmModel = llmModel::fromMap($map['llmModel']);
        }
        if (isset($map['mail'])) {
            $model->mail = $map['mail'];
        }
        if (isset($map['mailOption'])) {
            $model->mailOption = $map['mailOption'];
        }
        if (isset($map['minutesTemplates'])) {
            if (!empty($map['minutesTemplates'])) {
                $model->minutesTemplates = [];
                $n = 0;
                foreach ($map['minutesTemplates'] as $item) {
                    $model->minutesTemplates[$n++] = null !== $item ? minutesTemplates::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['projectList'])) {
            if (!empty($map['projectList'])) {
                $model->projectList = [];
                $n = 0;
                foreach ($map['projectList'] as $item) {
                    $model->projectList[$n++] = null !== $item ? projectList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['prompt'])) {
            $model->prompt = $map['prompt'];
        }
        if (isset($map['promptTemplateIds'])) {
            if (!empty($map['promptTemplateIds'])) {
                $model->promptTemplateIds = $map['promptTemplateIds'];
            }
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['syncCollabSheetConfig'])) {
            $model->syncCollabSheetConfig = syncCollabSheetConfig::fromMap($map['syncCollabSheetConfig']);
        }
        if (isset($map['syncIsvSystemConfigs'])) {
            if (!empty($map['syncIsvSystemConfigs'])) {
                $model->syncIsvSystemConfigs = [];
                $n = 0;
                foreach ($map['syncIsvSystemConfigs'] as $item) {
                    $model->syncIsvSystemConfigs[$n++] = null !== $item ? syncIsvSystemConfigs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['syncYidaConfig'])) {
            $model->syncYidaConfig = syncYidaConfig::fromMap($map['syncYidaConfig']);
        }

        return $model;
    }
}
