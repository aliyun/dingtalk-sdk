<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data\appLink;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data\contactList;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data\picList;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data\relatedDoc;
use AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data\relatedLink;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 相关应用
     *
     * @var appLink[]
     */
    public $appLink;

    /**
     * @description 审核人
     *
     * @var string
     */
    public $approveName;

    /**
     * @description 联系人列表
     *
     * @var contactList[]
     */
    public $contactList;

    /**
     * @description 相关联系人
     *
     * @var string[]
     */
    public $contacts;

    /**
     * @description 创建者
     *
     * @var string
     */
    public $creatorName;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var int
     */
    public $gmtModify;

    /**
     * @description 高亮的词条别名
     *
     *
     * @var string[]
     */
    public $highLightWordAlias;

    /**
     * @description 内部群是否高亮
     *
     * @var bool
     */
    public $imHighLight;

    /**
     * @description 当为待审核词条的时候的父编号
     *
     * @var int
     */
    public $parentUuid;

    /**
     * @var picList[]
     */
    public $picList;

    /**
     * @description 相关文档
     *
     * @var relatedDoc[]
     */
    public $relatedDoc;

    /**
     * @description 相关链接
     *
     * @var relatedLink[]
     */
    public $relatedLink;

    /**
     * @description 服务群是否高亮
     *
     * @var bool
     */
    public $simHighLight;

    /**
     * @description 词条释义非富文本
     *
     * @var string
     */
    public $simpleWordParaphrase;

    /**
     * @description 分类名称
     *
     * @var string[]
     */
    public $tagsList;

    /**
     * @description 更新人
     *
     * @var string
     */
    public $updaterName;

    /**
     * @description 操作员工userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 词条主键ID
     *
     * @var int
     */
    public $uuid;

    /**
     * @description 词条别名
     *
     * @var string[]
     */
    public $wordAlias;

    /**
     * @description 词条名称
     *
     *
     * @var string
     */
    public $wordName;

    /**
     * @description 词条释义，富文本
     *
     * @var string
     */
    public $wordParaphrase;
    protected $_name = [
        'appLink'              => 'appLink',
        'approveName'          => 'approveName',
        'contactList'          => 'contactList',
        'contacts'             => 'contacts',
        'creatorName'          => 'creatorName',
        'gmtCreate'            => 'gmtCreate',
        'gmtModify'            => 'gmtModify',
        'highLightWordAlias'   => 'highLightWordAlias',
        'imHighLight'          => 'imHighLight',
        'parentUuid'           => 'parentUuid',
        'picList'              => 'picList',
        'relatedDoc'           => 'relatedDoc',
        'relatedLink'          => 'relatedLink',
        'simHighLight'         => 'simHighLight',
        'simpleWordParaphrase' => 'simpleWordParaphrase',
        'tagsList'             => 'tagsList',
        'updaterName'          => 'updaterName',
        'userId'               => 'userId',
        'uuid'                 => 'uuid',
        'wordAlias'            => 'wordAlias',
        'wordName'             => 'wordName',
        'wordParaphrase'       => 'wordParaphrase',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appLink) {
            $res['appLink'] = [];
            if (null !== $this->appLink && \is_array($this->appLink)) {
                $n = 0;
                foreach ($this->appLink as $item) {
                    $res['appLink'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->approveName) {
            $res['approveName'] = $this->approveName;
        }
        if (null !== $this->contactList) {
            $res['contactList'] = [];
            if (null !== $this->contactList && \is_array($this->contactList)) {
                $n = 0;
                foreach ($this->contactList as $item) {
                    $res['contactList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->contacts) {
            $res['contacts'] = $this->contacts;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModify) {
            $res['gmtModify'] = $this->gmtModify;
        }
        if (null !== $this->highLightWordAlias) {
            $res['highLightWordAlias'] = $this->highLightWordAlias;
        }
        if (null !== $this->imHighLight) {
            $res['imHighLight'] = $this->imHighLight;
        }
        if (null !== $this->parentUuid) {
            $res['parentUuid'] = $this->parentUuid;
        }
        if (null !== $this->picList) {
            $res['picList'] = [];
            if (null !== $this->picList && \is_array($this->picList)) {
                $n = 0;
                foreach ($this->picList as $item) {
                    $res['picList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->relatedDoc) {
            $res['relatedDoc'] = [];
            if (null !== $this->relatedDoc && \is_array($this->relatedDoc)) {
                $n = 0;
                foreach ($this->relatedDoc as $item) {
                    $res['relatedDoc'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->relatedLink) {
            $res['relatedLink'] = [];
            if (null !== $this->relatedLink && \is_array($this->relatedLink)) {
                $n = 0;
                foreach ($this->relatedLink as $item) {
                    $res['relatedLink'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->simHighLight) {
            $res['simHighLight'] = $this->simHighLight;
        }
        if (null !== $this->simpleWordParaphrase) {
            $res['simpleWordParaphrase'] = $this->simpleWordParaphrase;
        }
        if (null !== $this->tagsList) {
            $res['tagsList'] = $this->tagsList;
        }
        if (null !== $this->updaterName) {
            $res['updaterName'] = $this->updaterName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->wordAlias) {
            $res['wordAlias'] = $this->wordAlias;
        }
        if (null !== $this->wordName) {
            $res['wordName'] = $this->wordName;
        }
        if (null !== $this->wordParaphrase) {
            $res['wordParaphrase'] = $this->wordParaphrase;
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
        if (isset($map['appLink'])) {
            if (!empty($map['appLink'])) {
                $model->appLink = [];
                $n              = 0;
                foreach ($map['appLink'] as $item) {
                    $model->appLink[$n++] = null !== $item ? appLink::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['approveName'])) {
            $model->approveName = $map['approveName'];
        }
        if (isset($map['contactList'])) {
            if (!empty($map['contactList'])) {
                $model->contactList = [];
                $n                  = 0;
                foreach ($map['contactList'] as $item) {
                    $model->contactList[$n++] = null !== $item ? contactList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['contacts'])) {
            if (!empty($map['contacts'])) {
                $model->contacts = $map['contacts'];
            }
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModify'])) {
            $model->gmtModify = $map['gmtModify'];
        }
        if (isset($map['highLightWordAlias'])) {
            if (!empty($map['highLightWordAlias'])) {
                $model->highLightWordAlias = $map['highLightWordAlias'];
            }
        }
        if (isset($map['imHighLight'])) {
            $model->imHighLight = $map['imHighLight'];
        }
        if (isset($map['parentUuid'])) {
            $model->parentUuid = $map['parentUuid'];
        }
        if (isset($map['picList'])) {
            if (!empty($map['picList'])) {
                $model->picList = [];
                $n              = 0;
                foreach ($map['picList'] as $item) {
                    $model->picList[$n++] = null !== $item ? picList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['relatedDoc'])) {
            if (!empty($map['relatedDoc'])) {
                $model->relatedDoc = [];
                $n                 = 0;
                foreach ($map['relatedDoc'] as $item) {
                    $model->relatedDoc[$n++] = null !== $item ? relatedDoc::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['relatedLink'])) {
            if (!empty($map['relatedLink'])) {
                $model->relatedLink = [];
                $n                  = 0;
                foreach ($map['relatedLink'] as $item) {
                    $model->relatedLink[$n++] = null !== $item ? relatedLink::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['simHighLight'])) {
            $model->simHighLight = $map['simHighLight'];
        }
        if (isset($map['simpleWordParaphrase'])) {
            $model->simpleWordParaphrase = $map['simpleWordParaphrase'];
        }
        if (isset($map['tagsList'])) {
            if (!empty($map['tagsList'])) {
                $model->tagsList = $map['tagsList'];
            }
        }
        if (isset($map['updaterName'])) {
            $model->updaterName = $map['updaterName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['wordAlias'])) {
            if (!empty($map['wordAlias'])) {
                $model->wordAlias = $map['wordAlias'];
            }
        }
        if (isset($map['wordName'])) {
            $model->wordName = $map['wordName'];
        }
        if (isset($map['wordParaphrase'])) {
            $model->wordParaphrase = $map['wordParaphrase'];
        }

        return $model;
    }
}
