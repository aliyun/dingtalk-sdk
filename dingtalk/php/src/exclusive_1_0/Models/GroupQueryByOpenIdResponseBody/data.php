<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByOpenIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByOpenIdResponseBody\data\listGroupDynamicAttr;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $groupName;

    /**
     * @var string
     */
    public $groupTemplateId;

    /**
     * @var string
     */
    public $groupTemplateName;

    /**
     * @var string
     */
    public $groupTopic;

    /**
     * @var string
     */
    public $groupType;

    /**
     * @var int
     */
    public $id;

    /**
     * @var listGroupDynamicAttr[]
     */
    public $listGroupDynamicAttr;

    /**
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'groupName'            => 'groupName',
        'groupTemplateId'      => 'groupTemplateId',
        'groupTemplateName'    => 'groupTemplateName',
        'groupTopic'           => 'groupTopic',
        'groupType'            => 'groupType',
        'id'                   => 'id',
        'listGroupDynamicAttr' => 'listGroupDynamicAttr',
        'openConversationId'   => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }
        if (null !== $this->groupTemplateName) {
            $res['groupTemplateName'] = $this->groupTemplateName;
        }
        if (null !== $this->groupTopic) {
            $res['groupTopic'] = $this->groupTopic;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->listGroupDynamicAttr) {
            $res['listGroupDynamicAttr'] = [];
            if (null !== $this->listGroupDynamicAttr && \is_array($this->listGroupDynamicAttr)) {
                $n = 0;
                foreach ($this->listGroupDynamicAttr as $item) {
                    $res['listGroupDynamicAttr'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
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
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }
        if (isset($map['groupTemplateName'])) {
            $model->groupTemplateName = $map['groupTemplateName'];
        }
        if (isset($map['groupTopic'])) {
            $model->groupTopic = $map['groupTopic'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['listGroupDynamicAttr'])) {
            if (!empty($map['listGroupDynamicAttr'])) {
                $model->listGroupDynamicAttr = [];
                $n                           = 0;
                foreach ($map['listGroupDynamicAttr'] as $item) {
                    $model->listGroupDynamicAttr[$n++] = null !== $item ? listGroupDynamicAttr::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
